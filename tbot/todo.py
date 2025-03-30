import logging
from telegram import Update, InlineKeyboardButton, InlineKeyboardMarkup
from telegram.ext import ApplicationBuilder, CommandHandler, CallbackQueryHandler, ContextTypes, MessageHandler, filters
import json


# Set up logging
logging.basicConfig(
    format='%(asctime)s - %(name)s - %(levelname)s - %(message)s',
    level=logging.INFO
)

todolist = []
delete_mode_user = {}


def load_tasks():
    try:
        with open('tasks.json', 'r', encoding='utf-8') as f:
            tasks = json.load(f)
            return tasks if tasks else []
    except (FileNotFoundError, json.JSONDecodeError):
        return []


def save_tasks():
    with open('tasks.json', 'w', encoding='utf-8') as f:
        json.dump(todolist, f, ensure_ascii=False, indent=4)


async def start(update: Update, context: ContextTypes.DEFAULT_TYPE) -> None:
    try:
        global todolist
        todolist = load_tasks()
        logging.info(f"Todolist after loading: {todolist}")        
        await show_menu(update.message)        
    except Exception as e:
        logging.error(f"Error in start function: {e}")
        await update.message.reply_text("Вибачте, сталася помилка. Спробуйте ще раз.")


async def handle_user_input(update: Update, context: ContextTypes.DEFAULT_TYPE) -> None:
    if update.message.chat_id in delete_mode_user:        
        try:
            task_index = int(update.message.text) - 1
            if task_index >= 0 and task_index < len(todolist):
                todolist.pop(task_index)
                await update.message.reply_text(f"Задача видалена.")
            else:
                await update.message.reply_text("Невірний номер задачі.")
        except ValueError:
            await update.message.reply_text("Будь ласка, введіть правильний номер задачі.")
        
        # Remove delete mode after handling input
        delete_mode_user.pop(update.message.chat_id, None)
        await show_menu(update.message)
    else:
        # Regular task input
        task = update.message.text
        todolist.append(task)
        await update.message.reply_text("Added!")
        await show_menu(update.message)


async def handle_buttons(update: Update, context: ContextTypes.DEFAULT_TYPE) -> None:
    try:
        query = update.callback_query
        await query.answer()
        data = query.data
                
        if data == "list":
            text = "\n".join([f"{index + 1}. {task}" for index, task in enumerate(todolist)]) if todolist else "Список задач пуст."
        elif data == "add":
            await query.edit_message_text("Введіть задачу для додавання в список:")
            return
        elif data == "delete":
            delete_mode_user[update.callback_query.from_user.id] = True
            await query.edit_message_text("Введіть номер задачі для видалення:")
            return
        elif data == "clear":
            todolist.clear()
            text = "Список задач очищено!"
        elif data == "save":
            save_tasks()
            text = "Збережено!"
        else:
            text = "Невідома команда."

        await query.message.reply_text(text)
        await show_menu(query.message)

    except Exception as e:
        logging.error(f"Error handling button: {e}")
        if query:
            await query.edit_message_text("Вибачте, сталася помилка. Спробуйте ще раз.")


async def show_menu(message):
    keyboard = [
        [InlineKeyboardButton("➕ Add", callback_data="add")],
        [InlineKeyboardButton("📋 List", callback_data="list")],
        [InlineKeyboardButton("❌ Delete", callback_data="delete")],
        [InlineKeyboardButton("🆑 Clear", callback_data="clear")],
        [InlineKeyboardButton("✅ Save", callback_data="save")],
    ]
    reply_markup = InlineKeyboardMarkup(keyboard)
    await message.reply_text("Обери опцію:", reply_markup=reply_markup)


# Main function
def main():
    try:
        token = ""
        application = ApplicationBuilder().token(token).build()

        application.add_handler(CommandHandler("start", start))
        application.add_handler(CallbackQueryHandler(handle_buttons))
        application.add_handler(MessageHandler(filters.TEXT & ~filters.COMMAND, handle_user_input))

        print("Бот запущено...")
        application.run_polling()
    except Exception as e:
        logging.error(f"Main function error: {e}")

if __name__ == "__main__":
    main()

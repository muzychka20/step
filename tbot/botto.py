from telegram import Update
from telegram.ext import Application, CommandHandler, MessageHandler, filters, CallbackContext

# Токен вашего бота
TOKEN = ""

# Обработчик команды /start
async def start(update: Update, context: CallbackContext) -> None:
    await update.message.reply_text("Привет! Я ваш Telegram-бот. Чем могу помочь?")

# Обработчик команды /help
async def help_command(update: Update, context: CallbackContext) -> None:
    await update.message.reply_text("Я простой бот. Отправьте мне сообщение, и я его повторю!")

# Обработчик текстовых сообщений (Эхо-бот)
async def echo(update: Update, context: CallbackContext) -> None:
    await update.message.reply_text(update.message.text)

# Основная функция запуска бота
def main():
    app = Application.builder().token(TOKEN).build()
    
    # Добавляем обработчики команд
    app.add_handler(CommandHandler("start", start))
    app.add_handler(CommandHandler("help", help_command))
    
    # Добавляем обработчик текстовых сообщений
    app.add_handler(MessageHandler(filters.TEXT & ~filters.COMMAND, echo))
    
    # Запуск бота
    print("Бот запущен...")
    app.run_polling()

if __name__ == "__main__":
    main()
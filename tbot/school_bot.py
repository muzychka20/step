import logging
from telegram import Update, InlineKeyboardButton, InlineKeyboardMarkup
from telegram.ext import ApplicationBuilder, CommandHandler, CallbackQueryHandler, ContextTypes

# Set up logging
logging.basicConfig(
    format='%(asctime)s - %(name)s - %(levelname)s - %(message)s',
    level=logging.INFO
)

# Data for the bot
news = [
    "1. Початок навчального року: 1 вересня.",
    "2. День відкритих дверей: 15 вересня.",
    "3. Осінні канікули: з 23 жовтня по 29 жовтня."
]

schedule = {
    "5 клас": "1. Математика\n2. Українська мова\n3. Історія\n4. Фізкультура\n5. Природознавство",
    "6 клас": "1. Англійська мова\n2. Математика\n3. Біологія\n4. Географія\n5. Фізика",
    "7 клас": "1. Алгебра\n2. Хімія\n3. Література\n4. Географія\n5. Фізкультура",
    "8 клас": "1. Геометрія\n2. Історія\n3. Фізика\n4. Хімія\n5. Біологія",
    "9 клас": "1. Алгебра\n2. Українська мова\n3. Література\n4. Англійська мова\n5. Інформатика",
    "10 клас": "1. Українська мова\n2. Фізика\n3. Географія\n4. Хімія\n5. Біологія",
    "11 клас": "1. Історія\n2. Геометрія\n3. Алгебра\n4. Англійська мова\n5. Література"
}

bells = (
    "1 урок: 08:00 - 08:45\n"
    "2 урок: 09:00 - 09:45\n"
    "3 урок: 10:00 - 10:45\n"
    "4 урок: 11:00 - 11:45\n"
    "5 урок: 12:00 - 12:45\n"
    "6 урок: 13:00 - 13:45\n"
    "7 урок: 14:00 - 14:45"
)

consultations = (
    "Понеділок: Історія - 15:00 (вчитель: Петров Олег)\n"
    "Вівторок: Математика - 16:00 (вчитель: Іваненко Марія)\n"
    "Середа: Англійська мова - 15:30 (вчитель: Смирнова Оксана)\n"
    "Четвер: Фізика - 17:00 (вчитель: Коваль Дмитро)\n"
    "П'ятниця: Біологія - 16:00 (вчитель: Ткаченко Галина)"
)

# Start menu
async def start(update: Update, context: ContextTypes.DEFAULT_TYPE) -> None:
    try:
        keyboard = [
            [InlineKeyboardButton("🔔 Новини", callback_data="news")],
            [InlineKeyboardButton("📚 Розклад уроків", callback_data="schedule")],
            [InlineKeyboardButton("⏰ Розклад дзвінків", callback_data="bells")],
            [InlineKeyboardButton("👨‍🏫 Консультації викладачів", callback_data="consultations")],
        ]
        reply_markup = InlineKeyboardMarkup(keyboard)
        await update.message.reply_text("Привіт! Я шкільний бот. Оберіть опцію:", reply_markup=reply_markup)
    except Exception as e:
        logging.error(f"Error in start function: {e}")
        await update.message.reply_text("Вибачте, сталася помилка. Спробуйте ще раз.")

# Handle buttons
async def handle_buttons(update: Update, context: ContextTypes.DEFAULT_TYPE) -> None:
    try:
        query = update.callback_query
        await query.answer()
        data = query.data

        if data == "news":
            text = "🔔 Останні новини:\n" + "\n".join(news)
        elif data == "schedule":
            buttons = [[InlineKeyboardButton(f"{key}", callback_data=f"class_{key}")] for key in schedule.keys()]
            reply_markup = InlineKeyboardMarkup(buttons)
            await query.edit_message_text("Оберіть клас:", reply_markup=reply_markup)
            return
        elif data.startswith("class_"):
            class_name = data.split("_")[1]
            if class_name in schedule:
                text = f"📚 Розклад для {class_name} класу:\n" + schedule[class_name]
            else:
                text = f"Розклад для {class_name} не знайдено."
        elif data == "bells":
            text = "⏰ Розклад дзвінків:\n" + bells
        elif data == "consultations":
            text = "👨‍🏫 Консультації викладачів:\n" + consultations
        else:
            text = "Невідома команда."

        await query.edit_message_text(text)
    except Exception as e:
        logging.error(f"Error handling button: {e}")
        if query:
            await query.edit_message_text("Вибачте, сталася помилка. Спробуйте ще раз.")

# Main function
def main():
    try:
        token = ""
        application = ApplicationBuilder().token(token).build()

        application.add_handler(CommandHandler("start", start))
        application.add_handler(CallbackQueryHandler(handle_buttons))

        print("Бот запущено...")
        application.run_polling()
    except Exception as e:
        logging.error(f"Main function error: {e}")

if __name__ == "__main__":
    main()
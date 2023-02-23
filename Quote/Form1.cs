namespace Quote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[] phrases =
        {
        "Щаслива людина занадто задоволена сьогоденням, щоб занадто багато думати про майбутнє (Альберт Ейнштейн)",
        "Зміни – закон життя. І ті, хто дивиться тільки в минуле чи лише на сьогодення, безперечно – пропустять майбутнє (Джон Ф. Кеннеді)",
        "Навчання ніколи не вичерпує розум (Леонардо да Вінчі)",
        "Ми знаємо, хто ми є, але не знаємо, ким ми можемо бути (Вільям Шекспір)",
        "Я ніколи не віддам життя за свої переконання, тому що я можу помилятися (Бертран Рассел)"
        };
        private Color[] colors = { Color.OrangeRed, Color.DarkBlue, Color.Black };       

        private int phraseIndex = -1;
        private int colorIndex = -1;

        private void next_btn_Click(object sender, EventArgs e)
        {
            phraseIndex += 1;
            if (phraseIndex >= phrases.Length)  phraseIndex = 0;
            quote_label.Text = phrases[phraseIndex];

        }
        private void color_btn_Click(object sender, EventArgs e)
        {
            colorIndex += 1;
            if (colorIndex >= colors.Length) colorIndex = 0;
            quote_label.ForeColor = colors[colorIndex];
        }

        private void panel_btn_Click(object sender, EventArgs e)
        {
            var random = new Random();
            var quote = phrases[random.Next(phrases.Length)];
            DialogResult result = MessageBox.Show(quote, "Випадкова цитата", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK) quote_label.Text = quote;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
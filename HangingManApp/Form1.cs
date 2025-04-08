namespace HangingManApp


{
    public partial class Form1 : Form
    {
        // 🔹 Kelime listesi (istersen genişletebilirsin)
        private List<string> kelimeListesi = new List<string>
        {
            "KARPUZ", "BILGISAYAR", "CILEK", "YAZILIM", "FIRAT", "UZAY", "CSharp", "KOLEJ", "TEKNOFEST"
        };

        // 🔹 Oyun değişkenleri
        private string kelime; // seçilen kelime
        private char[] gizliKelime;
        private int can;
        private List<char> tahminEdilenHarfler = new List<char>();
        private Random rnd = new Random();
        private int toplamCan = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            YeniOyunBaslat();
        }

        private void YeniOyunBaslat()
        {
            if (kelimeListesi.Count == 0)
            {
                MessageBox.Show("Kelime listesi boş! Lütfen en az 1 kelime ekleyin.");
                return;
            }

            kelime = kelimeListesi[rnd.Next(kelimeListesi.Count)].ToUpper();
            gizliKelime = new string('_', kelime.Length).ToCharArray();
            can = toplamCan;
            tahminEdilenHarfler.Clear();

            lblKelime.Text = string.Join(" ", gizliKelime);
            lblCan.Text = $"Can: {can}";
            lblMesaj.Text = "";
            txtHarf.Clear();
            picAdam.Image = Image.FromFile("images/adam1.png");
            btnTahmin.Enabled = true;
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHarf.Text)) return;

            char harf = char.ToUpper(txtHarf.Text[0]);
            txtHarf.Clear(); 

            if (tahminEdilenHarfler.Contains(harf))
            {
                lblMesaj.Text = "Bu harfi zaten denedin!";
                return;
            }

            tahminEdilenHarfler.Add(harf);
            lblMesaj.Text = ""; 

            if (kelime.Contains(harf))
            {
                for (int i = 0; i < kelime.Length; i++)
                {
                    if (kelime[i] == harf)
                        gizliKelime[i] = harf;
                }

                lblKelime.Text = string.Join(" ", gizliKelime);
            }
            else
            {
                can--;
                lblCan.Text = $"Can: {can}";
                AdamCiz(can);
            }

            if (!gizliKelime.Contains('_'))
            {
                lblMesaj.Text = "Tebrikler! Kazandın!";
                btnTahmin.Enabled = false;
            }

            if (can == 0)
            {
                lblMesaj.Text = $"Kaybettin! Kelime: {kelime}";
                lblKelime.Text = kelime;
                btnTahmin.Enabled = false;
            }
        }

        private void AdamCiz(int kalanCan)
        {
            try
            {
                int resimNo = toplamCan - kalanCan + 1;
                string dosyaYolu = $"images/adam{resimNo}.png";
                if (File.Exists(dosyaYolu))
                    picAdam.Image = Image.FromFile(dosyaYolu);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Resim yüklenemedi: " + ex.Message);
            }
        }

        private void btnYeniden_Click(object sender, EventArgs e)
        {
            YeniOyunBaslat();
        }

        private void picAdam_Click(object sender, EventArgs e)
        {

        }
    }
}
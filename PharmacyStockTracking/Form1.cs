using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyStockTracking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Ilac> ilaclar = new List<Ilac>();
        
        private void button1_Click(object sender, EventArgs e)
        {
            Ilac ilac = new Ilac();

            if (!int.TryParse(txtNo.Text, out var no))
            {
                MessageBox.Show("Lütfen doğru bir ilaç numarası giriniz", "Uyarı", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!long.TryParse(txtBarkod.Text, out var barkod))
            {
                MessageBox.Show("Lütfen doğru bir barkod numarası giriniz", "Uyarı", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtFiyat.Text, out var fiyat))
            {
                MessageBox.Show("Lütfen fiyat kısmına sayı biçiminde veri girin", "Uyarı", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtAdet.Text, out var adet))
            {
                MessageBox.Show("Lütfen adet kısmına bir sayı giriniz", "Uyarı", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            ilac.IlacId = no;
            ilac.IlacAdi = txtAd.Text;
            ilac.SonKullanmaTarihi = dateTimePicker1.Value;
            ilac.BarkodNo = barkod;
            ilac.Fiyati = fiyat;
            ilac.Adedi = adet;

            ilaclar.Add(ilac);
            MessageBox.Show("İlaç eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var ilac in ilaclar)
            {
                ListViewItem item = new ListViewItem(ilac.IlacId.ToString());
                item.SubItems.Add(ilac.IlacAdi);
                item.SubItems.Add(ilac.SonKullanmaTarihi.ToString());
                item.SubItems.Add(ilac.BarkodNo.ToString());
                item.SubItems.Add(ilac.Fiyati.ToString());
                item.SubItems.Add(ilac.Adedi.ToString());

                listView1.Items.Add(item);
            }
        }
    }
}

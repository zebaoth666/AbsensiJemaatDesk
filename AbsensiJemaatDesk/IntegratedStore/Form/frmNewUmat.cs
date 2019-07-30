using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbsensiJemaatDesk
{
    public partial class frmNewUmat : Form
    {
        private String headerId = "";
        umatClass umat;
        pdClass pd;

        public frmNewUmat(String headerId, String maxUmatId)
        {
            InitializeComponent();
            this.headerId = headerId;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////                                          Event                                            //////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void frmNewUmat_Load(object sender, EventArgs e)
        {
            umat = new umatClass();
            pd = new pdClass();

            LblMenu.BackColor = ColorTranslator.FromHtml("#58D3F7");
            lblId.Text = getMaxNo();

            this.KeyDown += new KeyEventHandler(this.frmNewUmat_KeyDown);
        }

        private void frmNewUmat_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F4:
                    btnSimpan.PerformClick();
                    break;
                case Keys.Escape:
                    btnTutup.PerformClick();
                    break;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                iMessage.iBoxOk("Harap isi nama umat");
            }
            else
            {
                DialogResult result = iMessage.quBoxCon("Simpan data?");
                if (result == DialogResult.Yes)
                {
                    String sex = String.Empty;
                    String status = String.Empty;
                    if (rdPria.Checked)
                    {
                        sex = "P";
                    }
                    else sex = "W";

                    if (rdSingle.Checked)
                    {
                        status = "Single";
                    }
                    else status = "Married";

                    if (umat.saveUmat(lblId.Text, txtNama.Text.Trim(), txtAlias.Text.Trim(), txtAlamat.Text.Trim(),
                                            txtHp.Text.Trim(), txTempat.Text.Trim(), dtLahirJemaat.Value.ToShortDateString(),
                                            sex, txtParoki.Text.Trim(), txtLingkungan.Text.Trim(), txtTlpRmh.Text.Trim(),
                                            status, cmbAgama.Text, txtSibuk.Text.Trim(), txtKomunitas.Text.Trim(),
                                            cmbSosMed.Text, txtSosMed.Text.Trim()) == true
                                            && pd.insertLine(this.headerId, lblId.Text, txtNama.Text, txtAlias.Text, txTempat.Text,
                                            dtLahirJemaat.Value.ToShortDateString(), txtHp.Text, sex) == true)
                    {
                        iMessage.iBoxOk("Data berhasil disimpan");
                        this.Close();
                    }
                    else
                        iMessage.iBoxOk("Data gagal disimpan");
                }
            }
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private String getMaxNo()
        {
            string max = "";

            try
            {
                int lastVal = Convert.ToInt16(umat.nextId().Substring(2)) + 1;
                max = Convert.ToString(lastVal);

                while (max.Length != 4)
                {
                    max = "0" + max;
                }

                max = "U" + max;
            }
            catch (SystemException err) {
                iMessage.erBoxOk(err.Message);
            }

            return max;
        }
    }
}
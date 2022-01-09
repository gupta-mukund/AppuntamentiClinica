using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace AppuntamentiClinica
{
    public partial class Form1 : Form
    {
        List<Comparto> Patologie;
        List<Comparto> Specializzazioni;
        List<Appuntamento> Appuntamenti;
        List<Medico> Dottori;
        List<Paziente> Pazienti;
        public Form1()
        {
            InitializeComponent();
            
            dtpData.Enabled = cmbMedici.Enabled = cmbPazienti.Enabled = false;
            dtpData.Format = DateTimePickerFormat.Custom;
            dtpData.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            Patologie = new List<Comparto>();
            Specializzazioni = new List<Comparto>();
            Appuntamenti = new List<Appuntamento>();
            Dottori = new List<Medico>();
            Pazienti = new List<Paziente>();
            List<string[]> doctors = SaveDataObjects(Application.StartupPath + "/medici.csv");
            List<string[]> patologie = SaveDataObjects(Application.StartupPath + "/patologie.csv");
            List<string[]> specializzazioni = SaveDataObjects(Application.StartupPath + "/specializzazioni.csv");
            List<string[]> specializzazioni_patologie = SaveDataObjects(Application.StartupPath + "/specializzazioni_patologie.csv");
            List<string[]> appuntamenti = SaveDataObjects(Application.StartupPath + "/appuntamenti.csv");
            List<string[]> patients = SaveDataObjects(Application.StartupPath + "/pazienti.csv");
            
            AddObjects<Comparto>(patologie, ref Patologie);
            AddObjects<Comparto>(specializzazioni, ref Specializzazioni);
            AddObjects<Medico>(doctors, ref Dottori);
            AddObjects<Paziente>(patients, ref Pazienti);
            LinkaComparti(specializzazioni_patologie);
            AddObjects<Appuntamento>(appuntamenti, ref Appuntamenti);
            LinkDoctorsPatients(doctors, patients, appuntamenti);
            Console.WriteLine("");
            doctors = patologie = specializzazioni = specializzazioni_patologie = appuntamenti = patients = null;
            GC.Collect();
            cmbMedici.SelectedIndex = cmbPazienti.SelectedIndex = 0;
            dgwPazienti.DataSource = Pazienti.Select(o => new
            { Id = o.Id, Nome = o.Nome, Cognome = o.Cognome, Patologia = o.Patologia.Nome}).ToList();
            dgwMedici.DataSource = Dottori.Select(o => new
            { Id = o.Id, Nome = o.Nome, Cognome = o.Cognome, Patologia = o.Specializzazione.Nome }).ToList();
            dgwPatologie.DataSource = Patologie.Select(o => new
            { Nome = o.Nome, Id = o.Id}).ToList();
            dgwSpecializzazioni.DataSource = Specializzazioni.Select(o => new
            { Nome = o.Nome, Id = o.Id }).ToList();

            dgwAppuntamenti.DataSource = Appuntamenti.Select(o => new
            { Data = o.Data, Paziente = o.Paziente.GetFullName(), Medico = o.Medico.GetFullName()}).ToList();
        }

        private void LinkaComparti(List<string[]> data)
        {
            foreach (var item in data)
            {
                int ns = Convert.ToInt32(item[0]);
                int nd = Convert.ToInt32(item[1]);
                Specializzazioni[ns - 1].Soluzione.Add(Patologie[nd-1]);
                Patologie[nd - 1].Soluzione.Add(Specializzazioni[ns - 1]);

            }
        }

        private void LinkDoctorsPatients(List<string[]> doctors, List<string[]> patients, List<string[]> appuntamenti)
        {
            for (int i = 0; i < doctors.Count; i++)
            { 
                Dottori[i].Specializzazione = Specializzazioni[Convert.ToInt32(doctors[i][4])-1];
                cmbMedici.Items.Add(Dottori[i].GetFullName());
            }
            for (int i = 0; i < patients.Count; i++)
            {
                Pazienti[i].Patologia = Patologie[Convert.ToInt32(patients[i][5])-1];
                cmbPazienti.Items.Add(Pazienti[i].GetFullName());
            }
            for (int i = 0; i < appuntamenti.Count; i++)
            {
                string[] item = appuntamenti[i];
                int p = Convert.ToInt32(item[1]);
                int d = Convert.ToInt32(item[2]);
                Appuntamenti[i].Medico = Dottori[d - 501];
                Appuntamenti[i].Paziente = Pazienti[p - 1];
            }
        }
        private void AddObjects<T>(List<string[]> data, ref List<T> result)
        {
            foreach (var item in data)
            {
                //string soluzione = "";
                //foreach (var i in specializzazioni_patologie)
                //{
                //    if (i[1] == item[0])
                //    {
                //        soluzione = i[0];
                //    }
                //}
                if (typeof(T) == typeof(Comparto))
                {
                    Comparto tmp = new Comparto();
                    tmp.Id = item[0];
                    tmp.Nome = item[1];
                    result.Add((T)Convert.ChangeType(tmp, typeof(T)));
                }
                else if (typeof(T) == typeof(Appuntamento))
                {
                    Appuntamento tmp = new Appuntamento();
                    
                    tmp.Data = DateTime.ParseExact(item[0], "yyyy-MM-dd hh:mm:ss", null);
                    result.Add((T)Convert.ChangeType(tmp, typeof(T)));
                }
                else if (typeof(T) == typeof(Medico))
                {
                    Medico tmp = new Medico(item[0], item[1], item[2], item[3]);
                    result.Add((T)Convert.ChangeType(tmp, typeof(T)));

                }
                else if (typeof(T) == typeof(Paziente))
                {
                    Paziente tmp = new Paziente(item[0], item[1], item[2], item[6], item[3], item[4]);
                    result.Add((T)Convert.ChangeType(tmp, typeof(T)));
                }

            }
        }
        private List<string[]> SaveDataObjects(string fileName)
        {
            List<string[]> result = new List<string[]>();
            string[] rows = File.ReadAllLines(fileName);
            foreach (string item in rows)
            {
                string[] colums = item.Split(';');
                result.Add(colums);
            }
            result.RemoveAt(0);
            return result;
        }

        private void CheckBoxChanged(object sender, EventArgs e)
        {
            Dictionary<string, Control> elements = new Dictionary<string, Control>();
            elements.Add("Data", dtpData);
            elements.Add("Paziente", cmbPazienti);
            elements.Add("Medico", cmbMedici);
            
            CheckBox trigger = (CheckBox)sender;
            elements[trigger.Tag.ToString()].Enabled = trigger.Checked;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ckbData.Checked = ckbMedico.Checked = ckbPaziente.Checked = false;
            cmbMedici.SelectedIndex = cmbPazienti.SelectedIndex = 0;
            dtpData.Value = DateTime.Now;
            dgwAppuntamenti.DataSource = null;
            dgwAppuntamenti.DataSource = Appuntamenti.Select(o => new
            { Data = o.Data, Paziente = o.Paziente.GetFullName(), Medico = o.Medico.GetFullName() }).ToList();
        }

        private void btnFiltra_Click(object sender, EventArgs e)
        {
            List<Appuntamento> result = new List<Appuntamento>(Appuntamenti);
            if (ckbData.Checked)
            {
                result = result.Where(a => a.Data == dtpData.Value).ToList();
            }
            if (ckbMedico.Checked)
            {
                result = result.Where(a => a.Medico.GetFullName() == cmbMedici.Text).ToList();
            }
            if (ckbPaziente.Checked)
            {
                result = result.Where(a => a.Paziente.GetFullName() == cmbPazienti.Text).ToList();
            }

            if (result.Count > 0)
            {
                dgwAppuntamenti.DataSource = null;
                dgwAppuntamenti.DataSource = result.Select(o => new
                { Data = o.Data, Paziente = o.Paziente.GetFullName(), Medico = o.Medico.GetFullName() }).ToList();
            } else
            {
                MessageBox.Show("No result");
            }
            
        }
    }
}
 
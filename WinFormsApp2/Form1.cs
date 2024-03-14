using Microsoft.EntityFrameworkCore;
using WinFormsApp2.Model;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private DataContext? _context;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _context = new DataContext();
            _context.Database.EnsureCreated(); // untuk memastikan database sudah ada di sqlserver

            _context.SuperHeroes.Load();
            superHeroBindingSource.DataSource = _context.SuperHeroes.Local.ToBindingList();

            var autoCompleteSource = _context.SuperHeroes.Local.Select(sh => sh.FirstName + " " + sh.LastName + " - " + sh.Id).ToArray();
            AutoCompleteStringCollection src = new AutoCompleteStringCollection();
            src.AddRange(autoCompleteSource);
            txtBoxAutocomplete.AutoCompleteCustomSource = src;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _context.Dispose();
            _context = null;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            // buat data hero
            var newHero = new SuperHero();
            newHero.FirstName = txtFirstName.Text;
            newHero.LastName = txtLastName.Text;

            _context.SuperHeroes.Add(newHero); // menambahkan data ke DbSet<SuperHero>
            
            // simpan prubahan
            await _context.SaveChangesAsync();
        }
    }
}
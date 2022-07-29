using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace basvuruForm.Models.Entities
{
    public class FormContext : DbContext
    {
        //public FormContext(): base("name = FormContext")
        //{
        //}
        public FormContext(DbContextOptions<FormContext>options):base(options)
        {
            
        }

        

        public DbSet<Personal> Personal { get; set; }
        public DbSet<EgitimDurum> EgitimDurum { get; set; }
        public DbSet<GecmisIsYeriIstihdam> GecmisIsYeriIstihdam { get; set; }

    }
}

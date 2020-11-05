using Boligprospektet.Models.Models_Indhold_activitet;
using Boligprospektet.Models.Models_Indhold;
using Boligprospektet.Models.Models_Bolig_type_activitet;
using Boligprospektet.Models.Models_Bolig_type;
using Boligprospektet.Models.Models_Bolig_activitet;
using Boligprospektet.Models.Models_Facilitet;
using Boligprospektet.Models.Models_Bolig;
using Boligprospektet.Models.Models_User_activitet;
using Boligprospektet.Models.Models_User;
using Microsoft.EntityFrameworkCore; 
using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Threading.Tasks; 
 
namespace Boligprospektet.Models 
{ 
	public class AppDbContext : DbContext 
	{ 
		public AppDbContext(DbContextOptions<AppDbContext> options) 
			:base(options) 
		{ 
		} 
 
		//public DbSet<ABC> XYZs { get; set; } 	
		public DbSet<Indhold_activitet> Indhold_activitets { get; set; } 	
		public DbSet<Indhold> Indholds { get; set; } 	
		public DbSet<Bolig_type_activitet> Bolig_type_activitets { get; set; } 	
		public DbSet<Bolig_type> Bolig_types { get; set; } 	
		public DbSet<Bolig_activitet> Bolig_activitets { get; set; } 	
		public DbSet<Facilitet> Facilitets { get; set; } 	
		public DbSet<Bolig> Boligs { get; set; } 	
		public DbSet<User_activitet> User_activitets { get; set; } 	
		public DbSet<User> Users { get; set; } 
	} 
}

using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealmDb.Models
{
	public class Funcionario: RealmObject
	{
		[PrimaryKey]
		public long Id { get; set; }
		public string Nome { get; set; }
		public string Cargo { get; set; }
		public string Setor { get; set; }
		public string Qualificacao { get; set; }
	}
}

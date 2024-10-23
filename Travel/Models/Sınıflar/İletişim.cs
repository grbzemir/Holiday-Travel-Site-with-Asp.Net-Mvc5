﻿using System.ComponentModel.DataAnnotations;

namespace Travel.Models.Sınıflar
{
	public class İletişim
	{
		[Key]
		public int ID { get; set; }
		public string AdSoyad { get; set; }
		public string Mail { get; set; }
	    public string Konu { get; set; }
		public string Mesaj { get; set; }
	}
}

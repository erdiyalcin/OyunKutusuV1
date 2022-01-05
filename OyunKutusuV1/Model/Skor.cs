namespace OyunKutusuV1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Skor")]
    public partial class Skor
    {
        public int skorID { get; set; }

        public int? oyunID { get; set; }

        public int? kullaniciID { get; set; }

        public double? puan { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? tarih { get; set; }

        public int? sure { get; set; }

        public virtual Kullanici Kullanici { get; set; }

        public virtual Oyun Oyun { get; set; }
    }
}

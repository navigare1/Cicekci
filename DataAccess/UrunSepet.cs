namespace Cicekci.DataAccess
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class UrunSepet
    {
        [Key, Column(Order = 0)]
        public int UrunId { get; set; }

        [Key, Column(Order = 1)]
        [MaxLength(50)]
        public string SepetId { get; set; }
        public int Miktar { get; set; }
    
        public virtual Sepet Sepet { get; set; }
        public virtual Urun Urun { get; set; }
    }
}

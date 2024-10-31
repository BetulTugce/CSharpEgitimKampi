namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}

/*
 Field-Variable-Property
int x => doğrudan sınıfın içerisinde tanımlanırsa field
field gibi sınıf içerisinde tanımlanıyorsa ve get/set alıyorsa => property
Eğer bir değişken bir method içerisinde tanımlanıyorsa => variable
 */

using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System.Collections.Generic;

namespace CSharpEgitimKampi301.BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void TDelete(Customer entity)
        {
            _customerDal.Delete(entity);
        }

        public List<Customer> TGetAll()
        {
            return _customerDal.GetAll();
        }

        public Customer TGetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public void TInsert(Customer entity)
        {
            // Yetki varsa ekleme islemi yap yoksa uyari ver gibi hata, validasyon, yetki kontrolleri burada yapilir..
            if (entity.Name != "" && entity.Name.Length >= 3 && entity.Address != null && entity.Surname != "" && entity.Name.Length <= 30)
            {
                // Ekleme islemi yap
                _customerDal.Insert(entity);
            }
            else
            {
                // Hata mesaji ver
            }
        }

        public void TUpdate(Customer entity)
        {
            if (entity.CustomerId != 0 && entity.Address.Length >= 3)
            {
                _customerDal.Update(entity);
            }
            else
            {
                // Hata mesaji ver
            }
        }
    }
}

using MilkyProject.BusinessLayer.Abstract;
using MilkyProject.DataAccessLayer.Abstract;
using MilkyProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyProject.BusinessLayer.Concrete
{
    public class EmployeManager : IEmployeService
    {
        private readonly IEmployeDal _employeDal;

        public EmployeManager(IEmployeDal employeDal)
        {
            _employeDal = employeDal;
        }

        public void TDelete(int id)
        {
            _employeDal.Delete(id);
        }

        public Employe TGetById(int id)
        {
            return _employeDal.GetById(id);
        }

        public List<Employe> TGetListAll()
        {
            return _employeDal.GetListAll();
        }

        public void TInsert(Employe entity)
        {
            _employeDal.Insert(entity);
        }

        public void TUpdate(Employe entity)
        {
            _employeDal.Update(entity);
        }
    }
}

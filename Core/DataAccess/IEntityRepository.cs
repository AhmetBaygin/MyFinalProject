using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //class yazmak class olabilir değil referans tip olabilir demek
    //,Ientity yazmamızdaki amac T ya entitiy olabilir yada Ientitiy den implemente edilen bşy olabilir
    //new() :newlenebilir olmalı Ientity interface olduğu için newlenemediği için onu saf bırakmak için new()de yazdık
    public interface IEntityRepository<T> where T :class,IEntity,new()
    {
        //ürünleri kategoriye göre listele sqldeki where = bilmemne yazabilmemiz için alttakini yazmamız lazım
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
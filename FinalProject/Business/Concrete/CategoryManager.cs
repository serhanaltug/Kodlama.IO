using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(x => x.CategoryId == categoryId));
        }

        private IResult CheckIfCategoryCountCorrect(int categoryId) 
        {
            var result = _categoryDal.GetAll(x => x.CategoryId == categoryId).Count;
            if(result >= 15)
            {
                return new ErrorResult(Messages.CategoryCountError);
            }
            return new SuccessResult();
        }
    }
}

using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        [ValidationAspect(typeof(ColorValidator))]
        public IResult Add(Color color)
        {

            IResult result = BusinessRules.Run(CheckIfColorNameExists(color.ColorName));

            if (result != null) 
            {
               return result;
            }

            _colorDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(),Messages.CarListed);
        }

        public IDataResult<Color> GetByColorId(int colorId)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c => c.ColorId == colorId));
        }

        [ValidationAspect(typeof(ColorValidator))]
        public IResult Update(Color color)
        {
            IResult result = BusinessRules.Run(CheckIfColorNameExists(color.ColorName));

            if (result != null)
            {
                return result;
            }

            _colorDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }


        private IResult CheckIfColorNameExists(string colorName) 
        {
            var result = _colorDal.GetAll(c => c.ColorName == colorName).Any();
            if (result) 
            {
                return new ErrorResult(Messages.ColorError);
            }
            return new SuccessResult();
        }
    }
}

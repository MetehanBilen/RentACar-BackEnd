using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();


        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);

        IDataResult<Car> GetByCarId(int carId);

        IDataResult<List<CarDetailDto>> GetCarDetails();

        // Get By DailyPrice

    }
}

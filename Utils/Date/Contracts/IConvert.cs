using System;
using System.Collections.Generic;
using System.Text;

namespace Utils.Date.Contracts
{
    public interface IConvert<TConvertType> where TConvertType : class
    {
        public TConvertType Convert(string dateString);
    }
}

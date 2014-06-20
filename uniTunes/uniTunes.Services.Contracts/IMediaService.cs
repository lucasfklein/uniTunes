using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uniTunes.Models;

namespace uniTunes.Services.Contracts
{
    public interface IMediaService
    {
        List<Media> GetAll();
        List<Media> GetTop(int n);
        void Save(Media media);
    }
}

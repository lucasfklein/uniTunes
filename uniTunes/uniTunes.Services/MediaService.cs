using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uniTunes.Data.Infrastructure;
using uniTunes.Data.Repositories;
using uniTunes.Models;
using uniTunes.Services.Contracts;

namespace uniTunes.Services
{
    public class MediaService : IMediaService
    {
        private readonly IMediaRepository mediaRepository;
        private readonly IUnitOfWork unitOfWork;

        public MediaService(IMediaRepository mediaRepository, IUnitOfWork unitOfWork)
        {
            this.mediaRepository = mediaRepository;
            this.unitOfWork = unitOfWork;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Media> GetAll()
        {
            var medias = mediaRepository.GetAll();
            return medias.ToList();
        } 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public List<Media> GetTop(int number)
        {
            var medias = mediaRepository
                .GetAll()
                .OrderBy(y => y.CreatedOn)
                .Take(number);

            return medias.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="media"></param>
        public void Save(Media media)
        {
            mediaRepository.Add(media);
            unitOfWork.Commit();
        }
    }
}

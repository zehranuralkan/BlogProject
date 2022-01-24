using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewsLetterManager : INewsLetterService
    {
        INewsletterDal _newsletterDal;
        private EFNewsLetterRepository eFNewsLetterRepository;

        public NewsLetterManager(EFNewsLetterRepository eFNewsLetterRepository)
        {
            _newsletterDal = eFNewsLetterRepository;
        }

        public void AddNewsLetter(NewsLetter newsletter)
        {
            _newsletterDal.Insert(newsletter);
        }
    }
}

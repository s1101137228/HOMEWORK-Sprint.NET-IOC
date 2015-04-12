using KuasCore.Models;
using System.Collections.Generic;

namespace KuasCore.Services.Impl
{
    public class CompanyService : ICompanyService
    {

        public IList<Company> GetAllCompanies()
        {
            List<Company> companies = new List<Company>();

            Company company1 = new Company();
            company1.Id = "s1101137228";
            company1.Name = "田皓允";
            companies.Add(company1);

            Company company2 = new Company();
            company2.Id = "KUAS";
            company2.Name = "高雄應用科技大學";
            companies.Add(company2);

            return companies;
        }

        public Company GetCompanyById(string id)
        {

            Company company = null;
            
            if ("GSS".Equals(id))
            {
                company = new Company();
                company.Id = "s1101137228";
                company.Name = "田皓允";
            }

            return company;
        }

    }

}

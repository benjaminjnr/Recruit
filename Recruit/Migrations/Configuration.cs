using System;
using System.Data.Entity;
using Recruit.Models;
namespace Recruit.Migrations
{
    public class Configuration<T>: DropCreateDatabaseAlways<Models.RecruitDBContext>
    {
        protected override void Seed (Models.RecruitDBContext context)
        {
            context.Country.Add(
                new Country{ name = "Nigeria", code = "NG" }
            );

            context.Country.Add(
                new Country{ name = "South Africa", code = "ZA" }
            );

            context.State.Add(
                new State { name = "Lagos", country_code = "NG" }
            );

            context.State.Add(
                new State { name = "Abuja", country_code = "NG" }
            );

            context.Specialization.Add(
                new Specialization { name = "Accounting / Audit / Tax", code = "ACC" }
            );

            context.Specialization.Add(
                new Specialization { name = "Programming", code = "PRG" }
            );

            context.CareerLevel.Add(
                new CareerLevel { name = "Vocational/Semi-Skilled/Unskilled Labour", code = "SKILLED_LABOUR" }
            );

            context.CareerLevel.Add(
                new CareerLevel { name = "Undergraduate Internship/Vacation Job", code="UNDER_GRAD"}
            );

            context.CareerLevel.Add(
                new CareerLevel { name = "Fresh Graduate/Entry Level/Graduate Internship", code="ENTRY_LEVEL" }
            );

            context.CareerLevel.Add(
                new CareerLevel { name = "Experienced (Non-Manager)", code = "EXPERIENCED" }
            );

            context.CareerLevel.Add(
                new CareerLevel { name = "Manager (Staff Supervisor/Head of Department)", code = "MANAGER" }
            );

            context.CareerLevel.Add(
                new CareerLevel { name = "Executive (Director/CEO/CFO/COO)", code = "EXEC" }
            );

            base.Seed(context);
        }
    }
}

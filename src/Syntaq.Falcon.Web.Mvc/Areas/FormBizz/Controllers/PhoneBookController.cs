using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using Abp.AutoMapper;
using Microsoft.AspNetCore.Mvc;
using FormBizz.Authorization;
using FormBizz.Persons;
using FormBizz.Persons.Dto;
using FormBizz.Web.Areas.FormBizz.Models.Customers;
using FormBizz.Web.Controllers;
using System.Threading.Tasks;

namespace FormBizz.Web.Areas.FormBizz.Controllers
{
    [Area("FormBizz")] 
    [AbpMvcAuthorize(AppPermissions.Pages_PhoneBook)]

    public class PhoneBookController : FormBizzControllerBase
    {
        private readonly IPersonAppService _personAppService;

        public PhoneBookController(IPersonAppService personAppService)
        {
            _personAppService = personAppService;
        }

        // Get the all persons from the database 
        public ActionResult Index(GetPersonInput input)
        {
            var output = _personAppService.GetPersons(input);
            var model = ObjectMapper.Map<PersonViewModel>(output);
            model.Filter = input.Filter;
            return View(model);
        }

        // Set the permission on child 
        /*[AbpMvcAuthorize(AppPermissions.Pages_PhoneBook_Create)]
        public PartialViewResult CreatePersonModal()
        {
            return PartialView("_CreateOrEditModal");
        }*/

        // Set the permission on child 
        [AbpMvcAuthorize(AppPermissions.Pages_PhoneBook_Create, 
            AppPermissions.Pages_PhoneBook_Edit)]
        public async Task<PartialViewResult> CreatePersonModal(int? id)
        { 
            var output = await _personAppService.GetPersonForEdit(new NullableIdDto { Id = id });
            var viewModel = ObjectMapper.Map<CreateOrEditPersonModalViewModel>(output);
            return PartialView("_CreateOrEditModal", output);
        }
    }
}

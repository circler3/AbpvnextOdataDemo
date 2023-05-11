using Microsoft.AspNetCore.OData.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Domain.Repositories;

namespace TodoApp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TodoAppController : AbpControllerBase
{
    protected TodoAppController()
    {
        LocalizationResource = typeof(TodoAppResource);
    }
}


public class TodoAppImplController : TodoAppController
{
    private readonly ITodoAppService todoAppService;

    public TodoAppImplController(ITodoAppService todoAppService)
       :base() 
    {
        this.todoAppService = todoAppService;
    }

    [EnableQuery]
    public async Task<IEnumerable<TodoItemDto>> GetAsync()
    {
        var result = await todoAppService.GetListAsync();
        return result.AsQueryable();
    }
}

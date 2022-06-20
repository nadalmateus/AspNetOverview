﻿using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Blog.Extensions;

public static class ModelStateExtension
{
    public static List<string> GetErrors(this ModelStateDictionary modelState)
    {
        List<string> result = new();
        foreach (ModelStateEntry item in modelState.Values)
        {
            result.AddRange(item.Errors.Select(error => error.ErrorMessage));
        }

        return result;
    }
}
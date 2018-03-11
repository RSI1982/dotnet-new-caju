﻿namespace MyProject.UI.Presenters
{
    using MyProject.Application;
    using MyProject.Application.UseCases.CloseAccount;
    using Microsoft.AspNetCore.Mvc;

    public class ClosePresenter : IOutputBoundary<CloseOutput>
    {
        public IActionResult ViewModel { get; private set; }

        public CloseOutput Response { get; private set; }

        public void Populate(CloseOutput response)
        {
            Response = response;

            if (response == null)
            {
                ViewModel = new NoContentResult();
                return;
            }

            ViewModel = new OkResult();
        }
    }
}
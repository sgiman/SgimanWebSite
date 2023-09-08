//**********************************************************************************
// ErrorViewModel.cs
// ASP.NET Core MVC (.NET 7)
// ---------------------------------------------------------------------------------
//  �# | Visual Studio 2022
//  ASP.NET Core MVC (.NET 7) 
//  Template ASP NET (Model-View-Controller)
// ---------------------------------------------------------------------------------
// Gosha Dudar | �������� ASP.NET Core � ���� |
// ���������� ��� ������� �� Core MVC (.NET 6) 
//
// Writing by sgiman @ 2023
//**********************************************************************************

namespace SgimanWebSite.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
using BlazorFormPractice.Shared.Models;
using Microsoft.AspNetCore.Components.Forms;

namespace BlazorFormPractice.Client.Pages;

public partial class Index
{
  private Person _person = new();
  private EditContext _editContext = default!;
  private ValidationMessageStore _messageStore = default!;

  protected override void OnInitialized()
  {
    _editContext = new(_person);
    _messageStore = new(_editContext);
  }
}

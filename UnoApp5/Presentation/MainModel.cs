using System.Diagnostics;

namespace UnoApp5.Presentation;

public partial record MainModel
{
    private INavigator _navigator;

    public MainModel(IStringLocalizer localizer, IOptions<AppConfig> appInfo, INavigator navigator)
    {
        _navigator = navigator;
        Title = "Main";
        Title += $" - {localizer["ApplicationName"]}";
        Title += $" - {appInfo?.Value?.Environment}";
    }

    public string? Title { get; }

    public IState<string> Name => State<string>.Value(this, () => string.Empty);

    public async Task ShowModal(CancellationToken cancellationToken)
    {
        var option = await _navigator
            .NavigateViewForResultAsync<TestModal, TestResult>(
                this,
                qualifier: Qualifiers.Dialog,
                cancellation: cancellationToken
            )
            .AsResult();

        var data = option.SomeOrDefault();
        Debug.WriteLine($"Received result: {data?.Message ?? "null"}");
    }
}

public partial record Person(string Name);

namespace UnoApp5.Presentation;

[ReactiveBindable]
public partial record class TestModalModel
{
    private readonly INavigator _navigator;

    public TestModalModel(INavigator navigator)
    {
        _navigator = navigator;
    }

    public Task OnConfim(CancellationToken cancellationToken)
    {
        var result = new TestResult("Testing");
        return _navigator.NavigateBackWithResultAsync(
            this,
            data: result,
            cancellation: cancellationToken
        );
    }
}

public record TestResult(string Message);

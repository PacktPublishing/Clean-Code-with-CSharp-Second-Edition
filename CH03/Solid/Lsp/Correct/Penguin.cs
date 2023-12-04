using System;

namespace CH3.Solid.Lsp.Correct;

public class Penguin : IFlyable
{
    public void Fly()
    {
        throw new InvalidOperationException("Penguins cannot fly.");
    }
}

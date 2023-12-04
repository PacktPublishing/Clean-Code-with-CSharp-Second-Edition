using System;

namespace CH3.Solid.Lsp.Wrong;

public class Penguin : Bird
{
    public override void Fly()
    {
        throw new InvalidOperationException("Penguins cannot fly.");
    }
}

namespace Alura.Animais;

internal class Animal
{
    public virtual string EmitirSom()
    {
        return "O animal emite um som genérico.";
    }
}

internal class Mamifero : Animal
{
    public override string EmitirSom()
    {
        return "O mamífero emite um som característico.";
    }
}

internal class Ave : Animal
{
    public override string EmitirSom()
    {
        return "A ave emite um som característico.";
    }
}

internal class Peixe : Animal
{
    public override string EmitirSom()
    {
        return "O peixe emite um som característico.";
    }
}

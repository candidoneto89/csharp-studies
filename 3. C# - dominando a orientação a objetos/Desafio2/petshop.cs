namespace Alura.PetShop;

public class Pet
{
	public Pet(string nome, string especie, int idade)
	{
		Nome = nome;
		Especie = especie;
		Idade = idade;
	}

	public string Nome { get; }
	public string Especie { get; }
	public int Idade { get; }
	public Dono Dono { get; internal set; }

	public string Descricao => $"Pet: {Nome}, Espécie: {Especie}, Idade: {Idade} anos, Dono: {Dono?.Nome ?? "Sem dono"}";

}

public class Dono
{
	public Dono(string nome, string telefone) { 
		Nome = nome;
		Telefone = telefone;
	}

	public string Nome { get; }
	public string Telefone { get; }
	public List<Pet> Pets { get; } = new List<Pet>();

    public void RegistrarPet(Pet pet)
	{
		if (!Pets.Contains(pet))
		{
			Pets.Add(pet);
			pet.Dono = this;
		}
	}
	public string Descricao => $"Cliente: {Nome}, Telefone: {Telefone}\nPets: {string.Join(", ", Pets.Select(a => a.Nome))}";
}
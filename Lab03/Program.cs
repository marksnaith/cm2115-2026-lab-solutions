using Lab03;

// uncomment below for the first part of guided exercises, i.e. Character without ICharacter. Make sure to comment-out the code from line 11 onwards

// BlackHair hair = new BlackHair();
// BlueEyes eyes = new BlueEyes();
// Character alice = new Character(hair, eyes);

// alice.Describe();

ICharacter alice = new PlayableCharacter(new Hair(new BlackHair(), new ShortHair()), new BlueEyes(), new ArmouredOutfit());
ICharacter bob = new NonPlayableCharacter(new Hair(new BlondeHair(), new LongHair()), new GreenEyes(), new CasualOutfit());

alice.Move();
bob.Move();

List<ICharacter> characters = new List<ICharacter>();

ICharacter elf = new PlayableCharacter(new Hair(new BlackHair(), new LongHair()), new GreenEyes(), new CasualOutfit());
ICharacter dwarf = new NonPlayableCharacter(new Hair(new BlondeHair(), new ShortHair()), new BlueEyes(), new ArmouredOutfit());

characters.Add(alice);
characters.Add(bob);
characters.Add(elf);
characters.Add(dwarf);

foreach(ICharacter character in characters){
    character.Move();
}

Pet pet = new Pet(new BlackHair());
pet.Move();
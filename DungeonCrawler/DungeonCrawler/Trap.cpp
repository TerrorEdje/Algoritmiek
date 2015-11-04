#include "stdafx.h"
#include "Trap.h"
#include "RandomGenerator.h"

Trap::Trap()
{
	RandomGenerator rg;
	damage = rg.getRandom(0, 20);
}


int Trap::getDamage()
{
	return damage;
}

Trap::~Trap()
{
}

void Trap::setFound()
{
	found = true;
}

bool Trap::getFound()
{
	return found;
}
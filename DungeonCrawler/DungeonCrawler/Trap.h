#pragma once
class Trap
{
	bool found = false;
	int damage;
public:
	Trap();
	void setFound();
	~Trap();
	bool getFound();
	int getDamage();
};


from random import randint
from Mob import Mob
from Player import Player

class Field():

    @property
    def player(self) -> Player:
        return self.__player
    
    @property
    def mobs(self) -> Mob:
        return self.__mobs
    
    def __init__ (self, size, player, mobs):
        self.field = ["*" for i in range(size)]
        # self.player = player
        # self.mobs = mobs

    def display_info(self):
        print(f"{self.field}")

# John = Player("John", 100, 10)
# Monster = Mob("Monster", 100, 10)
new_field = Field(25)
new_field.display_info()


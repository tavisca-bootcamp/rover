package com.tavisca.workshops.Mapper;

import java.util.HashMap;

public class EnumToCharacterDirectionMapper {
    public final static HashMap<Directions, Character> DIRECTIONS_CHARACTER_HASH_MAP
            = new HashMap<>() {{
        put(Directions.EAST, 'E');
        put(Directions.SOUTH, 'S');
        put(Directions.WEST, 'W');
        put(Directions.NORTH, 'N');

    }};
}

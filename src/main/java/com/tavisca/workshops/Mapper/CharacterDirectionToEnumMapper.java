package com.tavisca.workshops.Mapper;

import java.util.HashMap;

public class CharacterDirectionToEnumMapper {
    public final static HashMap<Character, Directions> CHARACTER_DIRECTIONS_HASH_MAP
            = new HashMap<>() {{
        put('E', Directions.EAST);
        put('S', Directions.SOUTH);
        put('W', Directions.WEST);
        put('N', Directions.NORTH);

    }};

}

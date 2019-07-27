package com.tavisca.workshops.Motions;

import com.tavisca.workshops.Position.Vector;

import java.util.HashMap;

public class RotateDirections {
    private HashMap<Character, IRotate> characterIRotateHashMap;

    public RotateDirections() {
        characterIRotateHashMap = new HashMap<>() {{
            put('L', new LeftRotate());
            put('R', new RightRotate());
        }};
    }

    public Vector rotateVectorDirection(Vector currentVector, char command) {
        return characterIRotateHashMap.get(command).rotate(currentVector);
    }

}

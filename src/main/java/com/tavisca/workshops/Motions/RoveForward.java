package com.tavisca.workshops.Motions;

import com.tavisca.workshops.Mapper.Directions;
import com.tavisca.workshops.Position.Vector;

import java.util.HashMap;

public class RoveForward {
    private HashMap<Directions, IRoveForward> directionsIRoveForwardHashMap;

    public RoveForward() {
        directionsIRoveForwardHashMap = new HashMap<>() {{
            put(Directions.EAST, new RoveForwardInEastDirection());
            put(Directions.SOUTH, new RoveForwardInSouthDirection());
            put(Directions.WEST, new RoveForwardInWestDirection());
            put(Directions.NORTH, new RoveForwardInNorthDirection());
        }};
    }

    public Vector roveSingleStepForward(Vector currentVector) {
        return directionsIRoveForwardHashMap.get(currentVector.direction).roveForward(currentVector);
    }

}

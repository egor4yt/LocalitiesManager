export class WebApiAdaptor {
    /*
     * Make http get request
     * @returns {Object} JSON body
     */
    static async httpGetJsonAsync(url) {
        const promiseResponse = await fetch(url, {method: 'GET'});

        if (promiseResponse.ok === false) throw `The status code of request ${promiseResponse.url} was not ok`;

        let contentTypeHeader = promiseResponse.headers.get("content-type");
        if (!contentTypeHeader || contentTypeHeader.split(";")[0] !== "application/json") throw `The response to the request ${promiseResponse.url} was not json`;

        return await promiseResponse.json();
    }

    /*
     * Make http post request
     * @returns {Object} JSON body
     */
    static async httpPostJsonAsync(object, url) {
        const promiseResponse = await fetch(url, {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(object)
        });

        if (promiseResponse.ok === false) throw `The status code of request ${promiseResponse.url} was not ok`;

        let contentTypeHeader = promiseResponse.headers.get("content-type");
        if (!contentTypeHeader || contentTypeHeader.split(";")[0] !== "application/json") throw `The response to the request ${promiseResponse.url} was not json`;

        return await promiseResponse.json();
    }
}
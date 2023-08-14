export class ServerFilteringResponse {
    items = [];
    totalCount = 0;


    /*
     * @param {ServerFilteringSchema} schema - server filtering schema
     */
    constructor(schema, payload) {
        if (!schema) throw new Error("schema can't be null")
        if (!payload) throw new Error("data can't be null")

        this.items = payload[schema.itemsPropertyName];
        this.totalCount = payload[schema.totalCountPropertyName];
    }

}
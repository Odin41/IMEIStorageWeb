export default function (instance) {
    return {
        async getAll() {
            return await instance.get('api/IMEIAll');
        },
        async addImei(playload) {
            return await instance.post('api/IMEIAdd/'+playload);
        }
    }
}
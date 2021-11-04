<template>
    <div>
        <b-container>
            <b-table hover :fields="fields" :items="list">
               
            </b-table>
        </b-container>
    </div>
</template>

<script>
    import axios from 'axios';

    export default
        {
            data() {
                
                return {
                    fields: [
                        { key: 'imei', label: "IMEI" },
                        {
                            key: 'addedDate',
                            label: "Дата добавления",
                            formatter: value => {
                                var date = new Date(value);
                                return date.toLocaleDateString() + ' ' + date.toLocaleTimeString();
                            }
                        }
                    ],
                    items: [{ imei: '22', addedDate: 'sadasd' }],
                    list: null
                }
            },
            mounted() {
                axios
                    .get('http://127.0.0.1:5000/api/IMEIAll', {
                        headers: {
                            'Access-Control-Allow-Origin': '*',
                            'Access-Control-Allow-Methods': 'GET',
                            'Access-Control-Allow-Credentials':'true',
                            'Accept': 'application/json',
                            'Content-Type': 'application/json'
                        }
                    })
                    .then(response => (this.list = response.data));
            }
        }

</script>



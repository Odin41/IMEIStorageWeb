<template>
    <div id="app">
        <h1>IMEIStorage</h1>
        <hr />
        <IMEIAddForm />
        <IMEIList />
    </div>
</template>

<script>
    import  IMEIAddForm from '@/components/IMEIAddForm'
    import IMEIList from '@/components/IMEIList'


    export default {
        name: 'app',
        components: {
            IMEIList: IMEIList,
            IMEIAddForm: IMEIAddForm
        }
    };
</script>

<style>
</style>


<template>
    <div id="app">
        <div class="container">
            <div class="accordion-body">
                <div class="row mb-3">
                    <h2 class="display-6">IMEIStorage</h2>
                </div>
            </div>
        </div>
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


define("NavCredit80f98dbbSection", [], function() {
	return {
		entitySchemaName: "NavCredit",
		details: /**SCHEMA_DETAILS*/{}/**SCHEMA_DETAILS*/,
		diff: /**SCHEMA_DIFF*/[]/**SCHEMA_DIFF*/,
		methods: {
            /**dueDateValidator: function() {
                
                var invalidMessage = "";
                          
                if (this.get("NavDateEnd") - this.get("NavDateStart") == 31536000000) {
                   
                    invalidMessage = this.get("Resources.Strings.CreatedOnLessDueDateMessage");
                }
                
                return {
                    
                    invalidMessage: invalidMessage
                };
            },
           
            setValidationConfig: function() {
              
                this.callParent(arguments);
              
                this.addColumnValidator("NavDateEnd", this.dueDateValidator);
            
                this.addColumnValidator("NavDateStart", this.dueDateValidator);
            }*/}
	};
});

#Ember.Extension

This is the library that Ember extensions should reference.

This library contains only *annotations* that are common to both the Ember 
application and Ember extensions. This library contains no *logic* whatsoever.
The logic to load and manage extensions is located in the **Ember** project under 
the `Extension` namespace.

--- 

I  opted to separate common annotations into their own library the following 
reasons:

- Had I required that extension developers reference **Ember** instead of 
introducing **Ember.Extension**, the public interface would have been far too large 
and consequently, confounding. I *could* have conceivably maintained almost every
type to be of `internal` accessibility but to have done so would have both 
monotonous and error-prone.

- Isolating common annotations in **Ember.Extension** will allow me to more easily 
upload the the common annotations  to NuGet - hosting the library on NuGet will 
enable extension developers to retrieve updates more easily.
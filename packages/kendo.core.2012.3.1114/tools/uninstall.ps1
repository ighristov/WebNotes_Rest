param($installPath, $toolsPath, $package, $project)

$project |
	Remove-Paths 'kendo.core' |
	Remove-Shims 'kendo.core' | 
	Out-Null

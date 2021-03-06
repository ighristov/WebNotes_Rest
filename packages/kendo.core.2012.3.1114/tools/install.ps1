param($installPath, $toolsPath, $package, $project)

$project |
	Add-Paths "{
		'jQuery': 'Scripts/jQuery-1.9.0.min',
		'jQuery-migrate': 'Scripts/jquery-migrate-1.0.0.min',
		'kendo.core' : 'Scripts/kendo.core.min'
	}" |
	Add-Shims "{ 
		'jQuery': {
			'exports': 'jQuery'
		},
		'jQuery-migrate': {
			deps: ['jQuery']
		},
		'kendo.core': { 
			deps: ['jQuery-migrate']
		}
	}" | 
	Out-Null
